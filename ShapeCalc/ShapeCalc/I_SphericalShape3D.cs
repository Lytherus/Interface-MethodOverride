using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalc
{
    interface I_SphericalShape3D : I_InputRadius, I_CalculateVolume, I_CalculateSurfaceArea, I_OutputVolume, I_OutputSurfaceArea, I_WriteToText
    {
    }
}
