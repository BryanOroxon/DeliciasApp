using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliciasApp.Models;

public class DishesRepo
{
    public static List<PueblaDish> AllDishes => new List<PueblaDish>
    {
        new PueblaDish { Nombre = "Mole Poblano", Descripcion = "Plato tradicional de Puebla hecho con una salsa rica en chiles y chocolate.", ImagenUrl = "https://www.revistatravel.mx/images/showid2/6096105?w=1200&zc=4" },
        new PueblaDish { Nombre = "Chiles en Nogada", Descripcion = "Chiles poblanos rellenos de picadillo cubiertos con salsa de nuez y granada.", ImagenUrl = "https://www.revistatravel.mx/images/showid2/6096103?w=1200&zc=4" },
        new PueblaDish { Nombre = "Tacos Árabes", Descripcion = "Tacos de carne de cerdo marinada en especias, servidos en pan tipo pita.", ImagenUrl = "https://static.wixstatic.com/media/1e389d_5df68de570074900a71bd6a2aa0d4ce4~mv2.png/v1/fill/w_740,h_450,al_c,lg_1,q_85,enc_avif,quality_auto/1e389d_5df68de570074900a71bd6a2aa0d4ce4~mv2.png" },
        new PueblaDish { Nombre = "Cemitas Poblanas", Descripcion = "Sándwich típico de Puebla con milanesa, quesillo, aguacate y pápalo.", ImagenUrl = "https://www.revistatravel.mx/images/showid2/6096106?w=1200&zc=4" },
        new PueblaDish { Nombre = "Tinga Poblana", Descripcion = "Platillo de pollo deshebrado en salsa de jitomate, cebolla y chipotle.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZphoZb-bbzmpjL-DaPauOp8_18-AG5A7-BA&s" },
        new PueblaDish { Nombre = "Molotes Poblanos", Descripcion = "Masa rellena de papa o chorizo, frita y servida con salsa.", ImagenUrl = "https://cdn0.recetasgratis.net/es/posts/3/1/4/molotes_poblanos_75413_orig.jpg" },
        new PueblaDish { Nombre = "Enchiladas de Puebla", Descripcion = "Tortillas rellenas y bañadas en salsa roja o verde, típicas de Puebla.", ImagenUrl = "https://media-cdn.tripadvisor.com/media/photo-s/11/57/78/92/las-mejores-enchiladas.jpg" },
        new PueblaDish { Nombre = "Tamal de Dulce", Descripcion = "Tamal rosado y dulce, relleno de pasas, tradicional en celebraciones poblanas.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRT8O8IUnn38di6xx8efRGLxhlw14_jzZjbCQ&s" },
        new PueblaDish { Nombre = "Pipián Verde", Descripcion = "Platillo de pollo o cerdo en salsa de semillas de calabaza y chiles verdes.", ImagenUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTvdaK_NO7AXvFue9l4XYYabaq2KJHgU-xSZA&s" },
        new PueblaDish { Nombre = "Carne Enchilada", Descripcion = "Carne de cerdo marinada en chiles y especias, típica de la región.", ImagenUrl = "https://i.ytimg.com/vi/e514YXlY6Wg/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLAhUgqyulCUf7NRg0Os6yizX55tXA" },
        new PueblaDish { Nombre = "Tacos de Cecina", Descripcion = "Tacos hechos con cecina de res, acompañados de nopales y salsa.", ImagenUrl = "https://www.yosoypuebla.com/wp-content/uploads/2014/06/taco-barbacoa.jpg" },
        new PueblaDish { Nombre = "Chalupas Poblanas", Descripcion = "Tortillas pequeñas fritas con salsa, carne deshebrada y cebolla.", ImagenUrl = "https://assets.elgourmet.com/wp-content/uploads/2023/03/cover_u5qax3zv1l_chalupas.jpg" },
        new PueblaDish { Nombre = "Pelonas Poblanas", Descripcion = "Pan frito relleno de carne deshebrada, frijoles, lechuga y salsa.", ImagenUrl = "https://www.mexicodesconocido.com.mx/sites/default/files/styles/adaptive/public/fichas-destino/pelona-puebla-comida-antojito-pornfood-mexico.jpg" },
        new PueblaDish { Nombre = "Camotes Poblanos", Descripcion = "Dulce típico de Puebla hecho a base de camote y azúcar.", ImagenUrl = "https://diariosinsecretos.com/wp-content/uploads/2021/04/slide03.jpg" },
        new PueblaDish { Nombre = "Tortitas de Santa Clara", Descripcion = "Galletas rellenas de dulce de pepita, tradicionales de Puebla.", ImagenUrl = "https://aderezo.mx/wp-content/uploads/2021/11/DSC07610-1-1024x684.jpg" }
    };
}
