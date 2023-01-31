
namespace Week7.Task1
{
    public struct Worker
    {
        public Worker(string input)
        {
            var splitedInput = input.Split('#');

            try
            {
                Id = Convert.ToInt32(splitedInput[0]);
                CreatedAt = Convert.ToDateTime(splitedInput[1]);
                FullName = splitedInput[2];
                Age = Convert.ToInt32(splitedInput[3]);
                Higth = Convert.ToInt32(splitedInput[4]);
                DateOfBirth = Convert.ToDateTime(splitedInput[5]);
                PlaceOfBirth = splitedInput[6];
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int Higth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public override string ToString()
        {
            return $"{Id} {CreatedAt} {FullName} {Age} {Higth} {DateOfBirth.ToShortDateString()} {PlaceOfBirth}";
        }
        public string ToStoreFormat()
        {
            return $"{Id}#{CreatedAt}#{FullName}#{Age}#{Higth}#{DateOfBirth.ToShortDateString()}#{PlaceOfBirth}";
        }
    }
}
