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

            // tscmbPathPath tự điều chỉnh chiều dài
            clsTreeListView.CreateTreeView(this.treeView);
            tscmbPath.Width = this.Width - 120;
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy ổ đĩa hoặc thư mục đang được chọn
            TreeNode currentNode = e.Node;
            if (currentNode.Text != "This PC")
                clsTreeListView.ShowFolderTree(this.treeView, this.listView, currentNode);
            tscmbPath.Text = clsTreeListView.GetFullPath(currentNode.FullPath);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = this.listView.FocusedItem;
            clsTreeListView.ClickItem(this.listView, item);

            bool isOK = clsTreeListView.ClickItem(this.listView, item);
            if(isOK)
            {
                // Lấy giá trị đường dẫn từ ListViewItem (Path)
                if (item.SubItems[1].Text == "Folder")
                    tscmbPath.Text = item.SubItems[4].Text + "\\";
            }
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

        private void tsbtnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if(tscmbPath.Text != "")
                {
                    FileInfo f = new FileInfo(tscmbPath.Text.Trim());
                    if (f.Exists)
                    {
                        System.Diagnostics.Process.Start(tscmbPath.Text.Trim());
                        DirectoryInfo parent = f.Directory;
                        tscmbPath.Text = parent.FullName;
                        return;
                    }
                    else
                    {
                        clsTreeListView.ShowContent(listView, tscmbPath.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tscmbPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nhấn Enter
            if(e.KeyChar == 13)
            {
                clsTreeListView.ShowContent(this.listView, tscmbPath.Text);
            }
        }

        private void listView_SizeChanged(object sender, EventArgs e)
        {
            tscmbPath.Width = this.Width - 120;
        }

        // Trước khi viết lệnh cho các sự kiện copy, cut, paste,...
        // ,cần khai báo các biến sau
        private bool isCopying = false;
        private bool isFolder = false;
        private bool isListView = false;
        private ListViewItem itemPaste;
        private string pathFolder;
        private string pathFile;

        private void menuCopy_Click(object sender, EventArgs e)
        {
            isCopying = true;
            if(listView.Focused)
            {
                isListView = true;
                itemPaste = listView.FocusedItem;
                if (itemPaste == null)
                    return;
                if (itemPaste.SubItems[1].Text.Trim() == "Folder")
                {
                    isFolder = true;
                    pathFolder = itemPaste.SubItems[4].Text + "\\";
                }
                else
                {
                    isFolder = false;
                    pathFile = itemPaste.SubItems[4].Text;
                }
            }
            else if(treeView.Focused)
            {
                isListView = false;
                isFolder = true;
            }
            menuPaste.Enabled = true;
            tsbtnPaste.Enabled = true;
        }
    }
}
