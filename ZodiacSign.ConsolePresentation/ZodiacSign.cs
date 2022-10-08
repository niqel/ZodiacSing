using ZodiacSign.AppBusiness.UseCases;

namespace ZodiacSign.ConsolePresentation
{
    public class ZodiacSign 
    {
        private IPresenter presenter;
        private string[] monts;

        public ZodiacSign(IPresenter presenter)
        {
            monts = new string[12];
            monts[0] = "January";
            monts[1] = "February";
            monts[2] = "March";
            monts[3] = "April";
            monts[4] = "May";
            monts[5] = "June";
            monts[6] = "July";
            monts[7] = "August";
            monts[8] = "September";
            monts[9] = "October";
            monts[10] = "November";
            monts[11] = "December";
            
            this.presenter = presenter;
            Console.Clear();
            this.GetSign();
        }

        public void GetSign()
        {
            int continuar = 1;

            while (continuar == 1)
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("*             Menu de opciones             *");
                Console.WriteLine("********************************************");
                Console.WriteLine("1.- Buscar todos los signos");
                Console.WriteLine("2.- Buscar signo por fecha de nacimiento");

                Console.WriteLine("Por favor teclee el numero de opcion deseada");
                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Signos:");
                          
                            var signs = this.presenter.GetAllSigns.Handle().Result;
                            Console.Clear();
                            foreach (var item in signs)
                            {
                                Console.WriteLine($"Signo: {item.Name}");
                                Console.WriteLine($"Desde: {monts[item.FromMonth - 1]}-{item.FromDay}");
                                Console.WriteLine($"Hasta: {monts[item.UntilMonth - 1]}-{item.UntilDay}");
                                Console.WriteLine($"Gema: {item.Gem}");
                                Console.WriteLine($"Elemento: {item.Element}");
                                Console.WriteLine("Homes:");
                                foreach (var home in item.Homes)
                                {
                                    Console.WriteLine($"   {home.Name}");
                                }
                                Console.WriteLine("");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Por favor teclee su fecha de cumpleaños en este formato");
                            Console.WriteLine("YYYY-MM-DD");
                            try
                            {
                                DateTime fecha = Convert.ToDateTime(Console.ReadLine());
                                 var birthday = DateOnly.FromDateTime(fecha);
                                var sign = this.presenter.GetSignByBirthday.Handle(birthday).Result;
                                Console.Clear();
                                Console.WriteLine($"Signo: {sign.Name}");
                                Console.WriteLine($"Desde: {monts[sign.FromMonth - 1]}-{sign.FromDay}");
                                Console.WriteLine($"Hasta: {monts[sign.UntilMonth - 1]}-{sign.UntilDay}");
                                Console.WriteLine($"Gema: {sign.Gem}");
                                Console.WriteLine($"Elemento: {sign.Element}");
                                foreach (var home in sign.Homes)
                                {
                                    Console.WriteLine($"   {home.Name}");
                                }
                                Console.WriteLine("");
                            }
                            catch
                            {
                                Console.WriteLine("Por favor teclee su fecha de cumpleaños en este formato");
                            }
                            break;
                        default:
                            Console.WriteLine("Teclee una opcion valida por favor");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Teclee una opcion valida por favor");
                }
            }
        }
    }
}