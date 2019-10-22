﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_Utilidades
{
	public static class Validacao
	{
		public static IEnumerable<ValidationResult> getValidationErrors(object obj)
		{
			var resultadoValidacao = new List<ValidationResult>();
			var contexto = new ValidationContext(obj, null, null);
			Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);

			return resultadoValidacao;
		}
	}
}
