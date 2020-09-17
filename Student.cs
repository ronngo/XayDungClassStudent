using System;

namespace bai2
{

    
    internal class Student
    {
        private string name;
        private string address;
        private int age;
        private int id;

        public Student(){}
    public  Student(int _id, string _name, string _address, int _age){
        this.id = _id;
        this.name = _name;
        this.address = _address;
        this.age = _age;
    }

        

        public int GetId()
    {
        return this.id;
    }

    public void SetId(int _id)
    {
      this.id = _id;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string _name)
    {
      this.name = _name;
    }

     public string GetAndress()
    {
        return this.address;
    }

    public void SetAndress(string _address)
    {
      this.address = _address;
    }

     public int GetAge()
    {
        return this.age;
    }

    public void SetAge(int _age)
    {
      this.age = _age;
    }

        public override string ToString()
        {
            return "Id :" + id + "\n" + "Name :" + name + "\n" + "Andress :" + address + "\n" + "Age :" + age ;
        }

    }
}