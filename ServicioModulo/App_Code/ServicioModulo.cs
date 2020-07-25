using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class ServicioModulo : IServicioModulo
{
	public int calcularModulo(int e, int i)
	{
		if (Math.Abs(e) >= Math.Abs(i))
		{
			if(i == 0)
			{
				return -1;
			}
			else
			{
				return e % i;
			}
		}
		else
		{
			if(e == 0)
			{
				return -1;
			}
			else
			{
				return i % e;
			}
		}
	}

}
