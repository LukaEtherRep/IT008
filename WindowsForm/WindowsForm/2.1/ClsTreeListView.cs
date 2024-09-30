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
            // Tạo một node mới
            tnMyComputer = new TreeNode("My Computer", 0, 0);
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
                // Tạo một TreeNode cho từng đĩa
                diskTreeNode = new TreeNode(mo["Name"].ToString() + "\\", 0, 0);
                // Chèn vào Treeview
                nodeCollection.Add(diskTreeNode);
            }
        }

        public bool ShowFolderTree(TreeView treeView, TreeNode currentNode)
        {
            if(currentNode.Text != "My Computer")
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
                            nodeDir = new TreeNode(strName, 0, 0);
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
            return strPath.Replace("My Computer\\", "").Replace("\\\\", "\\");
        }
        public string GetName(string strPath)
        {
            string[] strSplit = strPath.Split('\\');
            int maxIndex = strSplit.Length;
            return strSplit[maxIndex - 1];
        }
    }
}
