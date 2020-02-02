using Sirb.Documents.BR.Enumeration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemDeFornecedores.Views
{
    public partial class FornecedoresPorEmpresaForm : Form
    {
        public FornecedoresPorEmpresaForm()
        {
            InitializeComponent();

           
            cboUF.DataSource = Enum.GetValues(typeof(State));
            txtCnpj.Mask = Sirb.Documents.BR.Validation.CNPJ.PlaceMask("00.000.000/0000-00");           
        }
    }
}
