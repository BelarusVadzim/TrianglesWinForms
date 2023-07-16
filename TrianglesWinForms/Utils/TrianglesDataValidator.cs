﻿using System.ComponentModel.DataAnnotations;
using TrianglesWinForms.Models;

namespace TrianglesWinForms.Utils
{
    public sealed class TrianglesDataValidator
    {
        public void Validate(TrianglesData trianglesData) 
        {
            ArgumentNullException.ThrowIfNull(nameof(trianglesData));

            if (trianglesData.Coordinates.Any(x => x.Length != 6 || x.Any(c => c < 0 || c > 1000)))
                throw new ValidationException("Invalid triangle coordinates");
        }
    }
}