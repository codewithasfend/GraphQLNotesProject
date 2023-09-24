using GraphQLProject.Models;

namespace GraphQLProject.Interfaces
{
    public interface INoteRepository
    {
        List<Note> GetAllNotes();
        Note GetNoteById(int id);
        Note AddNote(Note note);    
        Note UpdateNote(int id, Note note);
        void DeleteNote(int id);
    }
}
