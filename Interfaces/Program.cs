
using Interfaces;
using System.Security;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ProjectManager çatısı altında merkezden yönetebiliyoruz ve paramatreyi en genel olan personManager verdik
            //böylece onu implement eden tüm nesnelerimin referansını tutabiliyorum
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager()); // parametre personManager ama uygun olan tüm nesnelerimi yazabilrm.
            projectManager.Update(new InternManager());
            IPersonManager customerManager=new CustomerManager(); // customer ın referansını tutabilir
            customerManager.Add();

        }
    }
    interface IPersonManager
    {                // Yeni bir nesne geldiğinde önceden yazılmış kodlarım değişmeyecek
        void Add(); // aynı metodu farklı nesneler için farklı doldurabiliriz
        void Update();

    }
    public class EmployeeManager : IPersonManager
    {


        public void Add()
        {
            Console.WriteLine("Employee added");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }


    }


}
public class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Intern added");
    }

    public void Update()
    {
        Console.WriteLine("Intern updated");
    }


}
public class CustomerManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }

    public void Update()
    {
        Console.WriteLine("Customer updated");
    }


}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }

}


