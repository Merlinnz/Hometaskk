using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class ListController 
{
    private ListService _listService;
    public ListController()
    {
        _listService = new ListService();
    }
    
    [HttpGet]
    public List<GetListDto> GetLists()
    {
        return _listService.GetLists();
    }

    [HttpPost("Insert")]
        public int AddList(ListDto list)
        {
            return _listService.AddList(list);
        }
    
    [HttpPut("Update")]
        public int UpdateList(ListDto list)
        {
            return _listService.UpdateList(list);
        }
    
    [HttpDelete("Delete")]
        public int DeleteList(int id)
        {
            return _listService.DeleteList(id);
        }
}