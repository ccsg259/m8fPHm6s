﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capaDatos
{
    public class Encuesta
    {
        #region campos de la tabla
            string IdUnico  {get; set;}
            string Titulo   {get; set;}
            string Fecha    {get; set;}
        #endregion

        #region procedimientos y funciones de la tabla

        public void ActualizarNuevo(string IdUnico, string Titulo, string Usee, string Pass)
        {
            SqlConnection con = Conexion.ConectarSQL();
            SqlCommand cmd = new SqlCommand("spEncuesta");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pIdUnico", IdUnico.ToUpper());
            cmd.Parameters.AddWithValue("@pTitulo", Titulo);
            this.IdUnico = cmd.ExecuteScalar().ToString().ToUpper(); // regresa else IdUnico Insertado
        }
        public DataTable GetDatos()
        {
            DataTable dt = new DataTable();
            SqlConnection con = Conexion.ConectarSQL();
            con.Open();
            SqlCommand cmd = new SqlCommand("spGetEncuesta", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd); // se ejecuta el stored procedure y se traen los datos.
            da.Fill(dt);
            return dt; // Regresamos el DataTable
        }

        #endregion

        #region procedimientos para el tratamiento de componentes
       
        private TreeNode Searchnode(string nodetext, TreeView trv)
        {
            foreach (TreeNode node in trv.Nodes)
            {
                if (node.Text == nodetext)
                {
                    return node;
                }
            }
            return null;
        }


        protected void PopulateTreeView(TreeNode parentNode, string parentID, DataTable dtBloques)
        {
           
            foreach (DataRow bloque in dtBloques.Rows)
            {
                if (Convert.ToString(bloque["Id_Encuesta"]) == parentID)
                {
                    String text = bloque["Texto"].ToString();
                    parentNode.Nodes.Add(text);
                    
                }
            }
        }
        public void LLenarArbol(TreeView treeView)
        {
            DataTable dt = this.GetDatos();
            treeView.Nodes.Clear();
            TreeNode node = default(TreeNode);
            TreeNode subnode = default(TreeNode);

            foreach(DataRow row in dt.Rows)
            {
                node = Searchnode(row["Id_Unico"].ToString(), treeView);
                if(node != null)
                {
                    
                    DataTable dtB = new Bloque().GetDatos();
                    this.PopulateTreeView(node, row["Id_Unico"].ToString(), dtB);
                }
                else
                {
                    DataTable dtB = new Bloque().GetDatos();
                    node = new TreeNode(row["Titulo"].ToString());
                    this.PopulateTreeView(node, row["Id_Unico"].ToString(), dtB);
                    treeView.Nodes.Add(node);
                    
                                   
                }

            }
            treeView.ExpandAll();


        }
        #endregion




    }
}
