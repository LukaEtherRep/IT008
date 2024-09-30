using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

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
            ManagementObjectSearcher query = new ManagementObjectSearcher("Select * From Wìn_LogicalDisk");
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
    }
}
