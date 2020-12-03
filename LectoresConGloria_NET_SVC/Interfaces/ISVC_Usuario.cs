﻿using LectoresConGloria_MDL.Modelos;

namespace LectoresConGloria_SVC.Interfaces
{
    public interface ISVC_Usuario : IServicio<MDL_Usuario, int>,
        ISecurity<MDL_Usuario, MDL_Login>
    {

    }
}