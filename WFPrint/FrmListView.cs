using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPrint.Data;
using WFPrint.Models;

namespace WFPrint
{
    public partial class FrmListView : Form
    {
        private List<vmItems> cartData = null;

        public FrmListView()
        {
            InitializeComponent();
            InitialiseCart();
        }

        private void FrmListView_Load(object sender, EventArgs e)
        {
            BindItem();
        }

        private void InitialiseCart()
        {
            try
            {
                var ColId = new BrightIdeasSoftware.OLVColumn("ID", "ID");
                ColId.AspectGetter = x => (x as vmItems).ItemId;
                ColId.Width = 0;

                var ColQty = new BrightIdeasSoftware.OLVColumn("QTY", "QTY");
                ColQty.AspectGetter = x => (x as vmItems).ItemQty;
                ColQty.Width = 50;
                ColQty.TextAlign = HorizontalAlignment.Left;

                var ColName = new BrightIdeasSoftware.OLVColumn("ITEM", "ITEM");
                ColName.AspectGetter = x => (x as vmItems).ItemName;
                ColName.Width = 150;

                var ColTotal = new BrightIdeasSoftware.OLVColumn("PRICE", "PRICE");
                ColTotal.AspectGetter = x => (x as vmItems).ItemTotal;
                ColTotal.TextAlign = HorizontalAlignment.Center;

                this.treeListView1.Columns.Add(ColQty);
                this.treeListView1.Columns.Add(ColName);
                this.treeListView1.Columns.Add(ColTotal);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BindItem()
        {
            try
            {
                if (CartData.GetData().Count() > 0)
                {
                    this.treeListView1.Roots = null;
                    this.treeListView1.Roots = CartData.GetData();
                    this.treeListView1.CanExpandGetter = x => (x as vmItems).vmChildItems.Count > 0;
                    this.treeListView1.ChildrenGetter = x => (x as vmItems).vmChildItems;
                    this.treeListView1.ExpandAll();
                    this.treeListView1.TreeColumnRenderer.IsShowLines = false;
                    this.treeListView1.TreeColumnRenderer.IsShowGlyphs = false;
                    this.treeListView1.Refresh();
                    //this.treeListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    //this.treeListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    //this.treeListView1.UseAlternatingBackColors = true;
                    //this.treeListView1.AlternateRowBackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {
                    this.treeListView1.Roots = null;
                    //this.treeListView1.Rows.Clear();
                    //this.treeListView1.Columns.Clear();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.treeListView1.Roots != null)
                {
                    if (checkBox1.Checked)
                    {
                        this.treeListView1.ExpandAll();
                    }
                    else
                    {
                        this.treeListView1.CollapseAll();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void treeListView1_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            try
            {
                if (e.RowIndex == 0)
                {
                    e.Item.ForeColor = Color.Red;
                }

                dynamic item = e.Model; bool isChild = item.IsChild;
                if (isChild)
                {
                    e.Item.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void treeListView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var x = treeListView1.SelectedObjects[0];
                var nameOfProperty = "ItemId";
                var propertyInfo = x.GetType().GetProperty(nameOfProperty);
                var ItemId = propertyInfo.GetValue(x, null);

                var nameOfPropertyhp = "IsChild";
                var propertyInfohp = x.GetType().GetProperty(nameOfPropertyhp);
                var IsChild = propertyInfohp.GetValue(x, null);

                string itemId = Convert.ToString(ItemId);
                bool isChild = Convert.ToBoolean(IsChild);
                MessageBox.Show("ItemId Selected: " + itemId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
