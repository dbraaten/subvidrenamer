using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

/// <summary>
/// A simple utility to help with renaming files that exist in folders that have more correct names than
/// the files themselves.
/// </summary>
namespace SubVidRenamer
{
	public partial class MainForm : Form
	{
		private static string SVRregPath = @"Software\DigiBee\Renamer";
		private List<string> sourcePaths;
		private List<string> destPaths;
		public MainForm()
		{
			InitializeComponent();
			sourcePaths = new List<string>();
			destPaths = new List<string>();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			RegistryKey rk = null;
			rk = Registry.CurrentUser;
			using (RegistryKey ak = rk.OpenSubKey(SVRregPath))
			{
				if (ak != null)
				{
					int? setName = ak.GetValue("Set") as int?;
					if (setName != null)
					{
						checkSetNames.Checked = setName != 0;
					}

					string parm = ak.GetValue("LastFolder") as string;
					if (parm != null)
					{
						textFolder.Text = parm;
					}
					parm = ak.GetValue("Extensions") as string;
					if (parm != null)
					{
						textExtensions.Text = parm;
					}
					else
					{
						textExtensions.Text = "mp4;mkv;avi";
					}
				}
			}
			//Following is not necessary, when textExtensions.Text is set, it will scan from the event handler
			//if (textFolder.Text.Count() > 0 && textExtensions.Text.Count() > 0)
			//{
			//	ScanFolder();
			//}
		}

		/// <summary>
		/// Find files in fp that have one of the extensions in exts and add them to the sourcePaths
		/// </summary>
		/// <param name="fp">The folder path</param>
		/// <param name="exts">The extensions</param>
		private void ScanForFiles(string fp, string[] exts)
		{
			foreach (string ext in exts)
			{
				IEnumerable<string> filelist = null;
				try
				{
					string fileglob = string.Format("*.{0}", ext);
					filelist = Directory.EnumerateFiles(fp, fileglob);
				}
				catch (Exception ex)
				{
					//errors.Add(ex.Message);
				}
				if (filelist != null)
				{
					foreach (string fn in filelist)
					{
						sourcePaths.Add(fn);
					}
				}
			}
		}

		/// <summary>
		/// Find the directories in the given source folder and then scan for the files in each of those directories.
		/// Calls ProcessSourcePaths as the final step to populate the destPaths list.
		/// </summary>
		private void ScanFolder()
		{
			listBoxSource.DataSource = null;
			sourcePaths.Clear();
			listBoxFinal.DataSource = null;
			destPaths.Clear();
			string[] exts = textExtensions.Text.Split(';');
			try
			{
				//Queue<String> folderpaths = new Queue<string>();
				//while (folderpaths.Count > 0)
				{
					string folderpath = textFolder.Text;
					IEnumerable<string> folderlist = null;
					try
					{
						folderlist = Directory.EnumerateDirectories(folderpath, "*");//* for folders so we can search those
					}
					catch (Exception ex)
					{
						//errors.Add(ex.Message);
					}
					if (folderlist != null)
					{
						foreach (string fp in folderlist)
						{
							//folderpaths.Enqueue(fp);
							ScanForFiles(fp, exts);
						}
					}
				}
			}
			catch (Exception ex)
			{
				sourcePaths.Add(ex.Message);
			}
			listBoxSource.DataSource = sourcePaths;
			ProcessSourcePaths();
		}

		/// <summary>
		/// Transform the list in sourcePaths to what the new names will be and place in destPaths
		/// </summary>
		void ProcessSourcePaths()
		{
			listBoxFinal.DataSource = null;
			destPaths.Clear();
			bool bParent = checkSetNames.Checked;
			foreach (string src in sourcePaths)
			{
				string subPath = Path.GetDirectoryName(src);
				string fullPath = Path.GetFullPath(src);
				string ext = Path.GetExtension(src);
				string basePath = Path.GetDirectoryName(subPath);
				string filename = Path.GetFileNameWithoutExtension(src);
				if (bParent)
				{
					filename = Path.GetFileName(subPath);
				}
				string destPath = Path.Combine(basePath, filename) + ext;
				destPaths.Add(destPath);
			}
			listBoxFinal.DataSource = destPaths;

			if (destPaths.Count > 0 && sourcePaths.Count > 0)
			{
				buttonRename.Enabled = true;
			}
		}

		private void OnClosing(object sender, FormClosingEventArgs e)
		{
			if (textFolder.Text.Count() > 0 || textExtensions.Text.Count() > 0)
			{
				RegistryKey rk = null;
				rk = Registry.CurrentUser;
				RegistryKey key = rk.CreateSubKey(SVRregPath);
				if (key != null)
				{
					try
					{
						key.SetValue("LastFolder", textFolder.Text);
						key.SetValue("Extensions", textExtensions.Text);
						key.SetValue("Set", checkSetNames.Checked, RegistryValueKind.DWord);
					}
					catch (Exception ex)
					{
						//errors.Add(ex.Message);
					}
					finally
					{
						key.Close();
					}
				}
			}
		}

		private void OnFolderChanged(object sender, EventArgs e)
		{
			if (textFolder.Text.Count() > 0 && textExtensions.Text.Count() > 0)
			{
				ScanFolder();
			}
		}

		private void OnExtensionsChanged(object sender, EventArgs e)
		{
			if (textFolder.Text.Count() > 0 && textExtensions.Text.Count() > 0)
			{
				ScanFolder();
			}
		}

		private void OnClickedRename(object sender, EventArgs e)
		{
			buttonRename.Enabled = false;

			int nCnt = destPaths.Count;
			for (int i = 0; i < nCnt; i++)
			{
				try
				{
					File.Move(sourcePaths[i], destPaths[i]);
				}
				catch (Exception ex)
				{
					sourcePaths[i] = ex.Message;
				}
			}
		}

		private void OnClickedBrowse(object sender, EventArgs e)
		{
			FolderBrowserDialog fldr = new FolderBrowserDialog();
			fldr.Description = "Select the base folder for the scan.";
			fldr.ShowNewFolderButton = false;
			if (textFolder.Text.Length > 0)
				fldr.SelectedPath = textFolder.Text;

			if (fldr.ShowDialog() == DialogResult.OK)
			{
				textFolder.Text = fldr.SelectedPath;
			}
		}

		private void OnCheckedSetNames(object sender, EventArgs e)
		{
			if (textFolder.Text.Count() > 0 && textExtensions.Text.Count() > 0)
			{
				if (sourcePaths.Count < 1)
					ScanFolder();
				else
					ProcessSourcePaths();
			}
		}
	}
}
