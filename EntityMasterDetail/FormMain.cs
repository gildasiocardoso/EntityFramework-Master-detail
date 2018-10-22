using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;


namespace EntityMasterDetail
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// context is the object pointing to Entity Framework datamodel
        /// </summary>
        public MyDataModel.MYPORTFOLIOEntities context;
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            context = new MyDataModel.MYPORTFOLIOEntities();
            //binding datasource
            var query = context.GROUP_PRODUCT.OrderByDescending(c => c.DSC_GROUP_PRODUCT).ToList();
            gROUP_PRODUCTBindingSource.DataSource = query.ToList();
            gROUP_PRODUCTBindingNavigator.BindingSource = gROUP_PRODUCTBindingSource;
        }

        /// <summary>
        /// Saving on database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gROUP_PRODUCTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            
            gROUP_PRODUCTBindingSource.EndEdit();
            sUBGROUP_PRODUCTBindingSource.EndEdit();
            context.SaveChanges();
        }
    }
}
