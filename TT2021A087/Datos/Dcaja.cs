﻿using TT2021A087.CONEXION;
using TT2021A087.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TT2021A087.Datos
{
   public class Dcaja
    {
        string serialPC;
        public  void ObtenerIdcaja(ref int idcaja)
        {
            try
            {
                Bases.Obtener_serialPC(ref serialPC);
                CONEXIONMAESTRA.abrir();
                SqlCommand com = new SqlCommand("mostrar_cajas_por_Serial_de_DiscoDuro", CONEXIONMAESTRA.conectar);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Serial", serialPC);
                idcaja =Convert.ToInt32( com.ExecuteScalar());



            }
            catch (Exception ex)
            {
                idcaja = 0;
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();

            }
        }
    }
}
