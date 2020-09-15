using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Retangulo
{
    class Rectangle
    {
		//Definição das variáveis, lados 
		public double Height;
		public double Width;
		
		//Método de cálculo da área
		public double Area()
		{
			double areaRet = Height*Width;
			return areaRet;
		}

		//Método de cáclulo do perímetro
		public double Perimeter()
        {
			double periRet = 2 * Height + 2 * Width;
			return periRet;
        }

		//Método de cálculo da diagonal
		public double Diagonal()
		{
			return Math.Sqrt(Width * Width + Height * Height);
		}

		//Método ToString para inserir todas as informações unificadas
		public override string ToString()
		{
			return "Perímetro: "+Perimeter().ToString("F3", CultureInfo.InvariantCulture)
			+ " Área: "+ Area().ToString("F3", CultureInfo.InvariantCulture)
			+ " Diagonal: "+Diagonal().ToString("F3", CultureInfo.InvariantCulture);

		}

	}
}

