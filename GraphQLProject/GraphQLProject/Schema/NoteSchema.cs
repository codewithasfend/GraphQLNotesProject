using GraphQLProject.Mutation;
using GraphQLProject.Query;

namespace GraphQLProject.Schema
{
    public class NoteSchema : GraphQL.Types.Schema
    {
        public NoteSchema(NoteQuery noteQuery , NoteMutation noteMutation)
        {
            Query = noteQuery;
            Mutation = noteMutation;
        }
    }
}
