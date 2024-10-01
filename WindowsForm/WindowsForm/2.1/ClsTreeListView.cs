using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;


namespace _2._1
{
    internal class ClsTreeListView
    {
        public void CreateTreeView(TreeView treeView)
        {
            TreeNode tnMyComputer;
            const int RemovableDisk = 2;
            const int LocalDisk = 3;
            const int NetworkDisk = 4;
            const int CDDisk = 5;

            // Tạo một node mới
            tnMyComputer = new TreeNode("This PC", 0, 0);
            // Xóa Treeview
            treeView.Nodes.Clear();
            treeView.Nodes.Add(tnMyComputer);
            // Tập hợp các Node của tnMyComputer
            TreeNodeCollection nodeCollection = tnMyComputer.Nodes;
            // Lấy danh sách các ổ đĩa
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Win32_LogicalDisk");
            ManagementObjectCollection queryCollection = query.Get();
            foreach (ManagementObject mo in queryCollection.Cast<ManagementObject>())
            {
                TreeNode diskTreeNode;
                int imageIndex, selectIndex;
                // Gán các icon cho các ổ đĩa dựa trên các imageIndex và selectIndex
                switch (int.Parse(mo["DriveType"].ToString()))
                {
                    case RemovableDisk:
                        imageIndex = 1;
                        selectIndex = 1;
                        break;
                    case LocalDisk:
                        imageIndex = 2;
                        selectIndex = 2;
                        break;
                    case CDDisk:
                        imageIndex = 3;
                        selectIndex = 3;
                        break;
                    case NetworkDisk:
                        imageIndex = 4;
                        selectIndex = 4;
                        break;
                    default: // Thư mục
                        imageIndex = 5; // Đóng
                        selectIndex = 6; // Mở
                        break;
                }
                diskTreeNode = new TreeNode(mo["Name"].ToString()+"\\", imageIndex, selectIndex);
                /*
                // Tạo một TreeNode cho từng đĩa
                diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", 0, 0);
                // Bị thay thế bởi diskTreeNode bên trên
                */
                // Chèn vào Treeview
                nodeCollection.Add(diskTreeNode);
            }
        }

        public bool ShowFolderTree(TreeView treeView, ListView listView, TreeNode currentNode)
        {
            if(currentNode.Text != "This PC")
            {
                try
                {
                    // Kiểm tra đường dẫn
                    if (Directory.Exists(GetFullPath(currentNode.FullPath)) == false)
                        MessageBox.Show("Ổ đĩa hoặc thư mục không tồn tại");
                    else
                    {
                        string[] strDirectories = Directory.GetDirectories(GetFullPath(currentNode.FullPath));
                        // Lấy thông tin thư mục
                        foreach (string stringDir in strDirectories)
                        {
                            string strName = GetName(stringDir);
                            TreeNode nodeDir;
                            // Tạo các node cho thư mục
                            nodeDir = new TreeNode(strName, 5, 6);
                            currentNode.Nodes.Add(nodeDir);
                        }
                        // Hiển thị nội dung của thư mục đang lựa trên listView
                        ShowContent(listView, currentNode);
                    }
                    return true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Ổ đĩa hoặc thư mục không tồn tại");
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào ổ đĩa hoặc thư mục này");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        public string GetFullPath(string strPath)
        {
            return strPath.Replace("This PC\\", "").Replace("\\\\", "\\");
        }

        public string GetName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            int maxIndex = strSplit.Length;
            return strSplit[maxIndex - 1];
        }

        public void ShowContent(ListView listView, TreeNode currentNode)
        {
            try
            {
                // Xóa các item ListView
                listView.Items.Clear();
                ListViewItem item;
                DirectoryInfo directory = GetPathDir(currentNode);
                // Thông tin các thư mục
                foreach (DirectoryInfo folder in directory.GetDirectories())
                {
                    item = GetLVItems(folder);
                    listView.Items.Add(item);
                }
                // Thông tin các file
                foreach (FileInfo file in directory.GetFiles())
                {
                    item = GetLVItems(file);
                    listView.Items.Add(item);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public ListViewItem GetLVItems(DirectoryInfo folder)
        {
            string[] item = new string[5];
            item[0] = folder.Name;
            item[1] = "Folder";
            item[2] = folder.CreationTime.ToString();
            item[3] = folder.LastWriteTime.ToString();
            item[4] = folder.FullName;
            ListViewItem LVItem = new ListViewItem(item);
            return LVItem;
        }

        public ListViewItem GetLVItems(FileInfo file)
        {
            long size = 0;
            string[] s =
                {
                    file.Name, file.Extension.ToUpper(),
                    size + "KB", file.LastWriteTime.ToString(),
                    file.FullName, file.Directory.FullName
                };
            string[] item = new string[5];
            item[0] = file.Name;
            item[1] = (file.Length / 1024).ToString() + "KB";
            item[2] = file.CreationTime.ToString();
            item[3] = file.LastWriteTime.ToString();
            item[4] = file.FullName;
            ListViewItem LVitem = new ListViewItem(item);
            return LVitem;
        }
        public DirectoryInfo GetPathDir(TreeNode currentNode)
        {
            string[] strList = currentNode.FullPath.Split('\\');
            string strPath = strList.GetValue(1).ToString(); //+"\\";
            for(int i = 2; i<strList.Length; i++)
                strPath += strList.GetValue(i) + "\\";
            return new DirectoryInfo(strPath);
        }
    }
}
