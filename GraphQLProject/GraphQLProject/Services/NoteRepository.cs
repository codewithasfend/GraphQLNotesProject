using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Models;

namespace GraphQLProject.Services
{
    public class NoteRepository : INoteRepository
    {
        private GraphQLDbContext dbContext;

        public NoteRepository(GraphQLDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Note AddNote(Note note)
        {
            note.CreatedAt = DateTime.Now.ToString();
            dbContext.Notes.Add(note);
            dbContext.SaveChanges();
            return note;
        }

        public void DeleteNote(int id)
        {
            var noteResult = dbContext.Notes.Find(id);
            dbContext.Notes.Remove(noteResult);
            dbContext.SaveChanges();
        }

        public List<Note> GetAllNotes()
        {
            return dbContext.Notes.ToList();
        }

        public Note GetNoteById(int id)
        {
            return dbContext.Notes.Find(id);
        }

        public Note UpdateNote(int id, Note note)
        {
            var noteResult = dbContext.Notes.Find(id);
            noteResult.Title = note.Title;
            noteResult.Description = note.Description;
            noteResult.CreatedAt = DateTime.Now.ToString();
            dbContext.SaveChanges();
            return note;
        }
    }
}
