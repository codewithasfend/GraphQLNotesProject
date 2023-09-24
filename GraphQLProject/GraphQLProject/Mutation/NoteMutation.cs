using GraphQL;
using GraphQL.Types;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;
using GraphQLProject.Type;

namespace GraphQLProject.Mutation
{
    public class NoteMutation : ObjectGraphType
    {
        public NoteMutation(INoteRepository noteRepository)
        {
            Field<NoteType>("CreateNote").Arguments(new QueryArguments(new QueryArgument<NoteInputType> { Name = "note" })).Resolve(context =>
            {
                return noteRepository.AddNote(context.GetArgument<Note>("note"));
            });

            Field<NoteType>("UpdateNote").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "noteId" },
                new QueryArgument<NoteInputType> { Name = "note" })).Resolve(context =>
            {
                var menu = context.GetArgument<Note>("note");
                var menuId = context.GetArgument<int>("noteId");
                return noteRepository.UpdateNote(menuId, menu);
            });

            Field<StringGraphType>("DeleteNote").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "noteId" })).Resolve(context =>
               {

                   var noteId = context.GetArgument<int>("noteId");
                   noteRepository.DeleteNote(noteId);
                   return "The note against this Id " + noteId + " has been deleted";
               });
        }
    }
}
