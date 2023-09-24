using GraphQL.Types;
using GraphQLProject.Models;

namespace GraphQLProject.Type
{
    public class NoteType : ObjectGraphType<Note>
    {
        public NoteType()
        {
            Field(m => m.Id);
            Field(m => m.Title);
            Field(m => m.Description);
            Field(m => m.CreatedAt);
        }
    }
}
