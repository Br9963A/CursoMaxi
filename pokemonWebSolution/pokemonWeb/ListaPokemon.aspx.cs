﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

namespace pokemonWeb
{
	public partial class ListaPokemon : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			PokemonNegocio negocio = new PokemonNegocio();
			dgvPokemons.DataSource = negocio.listarConSp();
			dgvPokemons.DataBind();
		}
	}
}