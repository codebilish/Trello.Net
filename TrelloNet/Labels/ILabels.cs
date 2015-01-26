using System.Collections.Generic;

namespace TrelloNet
{
    public interface ILabels
    {
        /// <summary>
        /// GET /boards/[board_id]/labels
        /// <br/>
        /// Required permissions: read
        /// </summary>
        IEnumerable<Label> ForBoard(IBoardId board, int? limit = null);


    }
}
