using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevillaMath
{
    public class Video
    {
        public string Titulo { get; set; }
        public string Miniatura { get; set; }
        public string VideoUrl { get; set; }
        public string Descripcion { get; set; }
        public Command AbrirVideoCommand { get; set; }

        public Video()
        {
            AbrirVideoCommand = new Command(async () =>
            {
                var paginaVideo = new PaginaVideo(this);
                await Application.Current.MainPage.Navigation.PushAsync(paginaVideo, true);
            });
        }
    }
}
