using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliciasApp.Models;

public class PueblaDish
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string ImagenUrl { get; set; }
    public bool EsFavorito { get; set; }
}