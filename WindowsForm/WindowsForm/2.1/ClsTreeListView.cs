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

        public bool ShowFolderTree(TreeView treeView, TreeNode currentNode)
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
    }
}
