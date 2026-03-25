using CodeFirstEFinAsp.netcoreDemo.Models;

namespace CodeFirstEFinAsp.netcoreDemo.Repostories
{
    public interface IPost
    {
        List<Post> GetPosts();

        Post GetPostByID(int postid);

        void InsertPost(Post post);

        void DeletePost(int postid);

        void UpdatePost(Post post);

        void save();
    }
}
