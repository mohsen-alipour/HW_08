namespace WebAppHW_08.Models
{
    public class PersonRpository
    {

        private static  List<PersonModel> ListPerson = new List<PersonModel>
        {(new PersonModel(){Id = 101, Name = "Ali"}),
        (new PersonModel(){Id = 102, Name = "Mohsen"}),
        (new PersonModel(){Id = 103, Name = "Javad"}),
        (new PersonModel(){Id = 104, Name = "Amin"}),
        (new PersonModel(){Id = 105, Name = "Reza"})};

        public List<PersonModel> GetAllPerson()
        {
          var list= ListPerson.OrderByDescending(x => x.Id).ToList();
            return list; 
        }

        public void DeletPerson(int Personid)
        {
            var x = ListPerson.Where(x => x.Id == Personid).FirstOrDefault();
            ListPerson.Remove(x);
        }
        public PersonModel Getperson(int Personid)
        {
            var y= ListPerson.Where(x=>x.Id== Personid).FirstOrDefault();
            return y;
        }
        public void EditPerson(PersonModel _person)
        {

         ListPerson.Add(_person);
          
        }
    }

}
