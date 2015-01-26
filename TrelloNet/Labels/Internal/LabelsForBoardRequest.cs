using RestSharp;

namespace TrelloNet.Internal
{
    internal class LabelsForBoardRequest : BoardsRequest
    {
        public LabelsForBoardRequest(IBoardId board, int? limit = null): base(board, "labels")
        {
            if (limit.HasValue)
                this.AddParameter("limit", limit.Value);
        }
    }
}
