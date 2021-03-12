namespace Proxy.Person
{
    public class PersonBean : IPerson
    {
        private string name;
        private int likeCount;

        public void SetLikeCount(int like)
        {
            this.likeCount = like;
        }

        public int GetLikeCount()
        {
            return likeCount;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
