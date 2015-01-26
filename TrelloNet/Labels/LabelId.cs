using TrelloNet.Internal;

namespace TrelloNet
{
    public class LabelId : ILabelId
    {
        private readonly string _id;

        public LabelId(string id)
        {
            Guard.NotNullOrEmpty(id, "id");

            _id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public string GetLabelId()
        {
            return Id;
        }
    }
}