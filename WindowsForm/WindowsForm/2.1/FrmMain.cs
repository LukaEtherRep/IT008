using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class FrmMain : Form
    {
        private ClsTreeListView clsTreeListView = new ClsTreeListView();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            clsTreeListView.CreateTreeView(this.treeView);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy ổ đĩa hoặc thư mục đang được chọn
            TreeNode currentNode = e.Node;
            if (currentNode.Text != "This PC")
                clsTreeListView.ShowFolderTree(this.treeView, this.listView, currentNode);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = this.listView.FocusedItem;
            clsTreeListView.ClickItem(this.listView, item);
        }

        private void listView_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nhấn nút Enter
            if(e.KeyChar == 13)
            {
                ListViewItem item = this.listView.FocusedItem;
                clsTreeListView.ClickItem(this.listView, item);
            }
        }
    }
}
