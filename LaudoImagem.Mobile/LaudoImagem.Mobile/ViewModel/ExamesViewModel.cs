using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LaudoImagem.Mobile.ViewModel
{
    public class ExamesViewModel
    {
        #region Propriedades

        private List<Exame> _exames;
        public List<Exame> Exames
        {
            get
            {
                return _exames;
            }

            set
            {
                _exames = value;
            }
        }

        #endregion

        public ExamesViewModel()
        {
            Exames = Obter();
        }

        private List<Exame> Obter()
        {
            List<Exame> Exames1 = new List<Exame>();

            Exame Exame1 = new Exame();
            Exame1.Sigla = "AP";
            Exame1.Assinado=false;
            Exame1.Numero = "1600678AP";
            Exame1.Color = Color.Blue;

            Exames1.Add(Exame1);

            Exame1 = new Exame();
            Exame1.Sigla = "AP";
            Exame1.Assinado = true;
            Exame1.Numero = "1600555AP";
            Exame1.Color = Color.Green;

            Exames1.Add(Exame1);

            return Exames1;
        }

    }

    public class Exame
    {
        #region Propriedades

        private string _sigla = string.Empty;
        private string _numero = string.Empty;
        private string _paciente = string.Empty;
        private bool _assinado = false;
        private Color _color;

        public string Sigla
        {
            get
            {
                return _sigla;
            }

            set
            {
                _sigla = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Paciente
        {
            get
            {
                return _paciente;
            }

            set
            {
                _paciente = value;
            }
        }

        public bool Assinado
        {
            get
            {
                return _assinado;
            }

            set
            {
                _assinado = value;
            }
        }

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        #endregion
    }
}
