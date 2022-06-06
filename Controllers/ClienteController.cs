using LaPizza.DAO;
using LaPizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LaPizza.Controllers
{
    public class ClienteController
    {

        public void Adicionar(ClienteDto Cliente)
        {
            Context db = new Context();
            try
            {
                db.cliente.Add(Cliente);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um problema ao cadastrar Cliente, feche o cadastro e tente novamente! \n\n" + ex.Message,
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public int GetProximoId()
        {
            Context db = new Context();
            var cliente = db.cliente.FirstOrDefault();

            if (cliente is null)
                return 1;
            else
                return db.cliente.Max(p => p.id) + 1;
        }

        public bool ExisteClienteCpf(string Cpf)
        {
            Context db = new Context();
            ClienteDto cliente = db.cliente.Where(p => p.cpf == Cpf).FirstOrDefault();

            if (cliente != null && cliente.cpf == Cpf)
                return true;
            else
                return false;
        }
    }
}
