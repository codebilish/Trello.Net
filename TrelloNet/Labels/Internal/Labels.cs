using System.Collections.Generic;

namespace TrelloNet.Internal
{
    internal class Labels : ILabels
    {
        private readonly TrelloRestClient _restClient;

        public Labels(TrelloRestClient restClient)
        {
            _restClient = restClient;
        }

        public IEnumerable<Label> ForBoard(IBoardId board, int? limit = null)
        {
            return _restClient.Request<List<Label>>(new LabelsForBoardRequest(board, limit));
        }
    }
}
