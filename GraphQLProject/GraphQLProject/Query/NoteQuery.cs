using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Type;

namespace GraphQLProject.Query
{
    public class NoteQuery : ObjectGraphType
    {
        public NoteQuery(INoteRepository noteRepository)    
        {
            Field<ListGraphType<NoteType>>("Notes").Resolve(context =>
            {
                return noteRepository.GetAllNotes();
            });

            Field<NoteType>("Note").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "noteId"})).Resolve(context =>
            {
                return noteRepository.GetNoteById(context.GetArgument<int>("noteId"));
            });
        }
    }
}
