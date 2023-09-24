using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class NoteInputType : InputObjectGraphType
    {
        public NoteInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("title");
            Field<StringGraphType>("description");
            Field<StringGraphType>("createdAt"); 
        }
    }
}
