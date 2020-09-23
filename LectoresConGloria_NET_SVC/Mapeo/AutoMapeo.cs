using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Mapeo
{
    public sealed class Automapeo
    {
        private static IMapper instance = null;

        private Automapeo()
        {
        }

        public static IMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<AppProfile>();
                    });

                    instance = config.CreateMapper();
                }
                return instance;
            }
        }
    }
}
