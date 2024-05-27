using QLHSC07.Data.Repository;
using QLHSC07.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace QLHSC07.Data.Implements
{
    public interface IDocumentUploadRepository : IBaseRepository<DocumentUpload>
    {
    }

    public class DocumentUploadRepository : BaseRepository<DocumentUpload>, IDocumentUploadRepository
    {
        private readonly ILogger<DocumentUploadRepository> _logger;
        private readonly IConfiguration _configuration;
        
        public DocumentUploadRepository(AppDbContext context, IConfiguration configuration, ILogger<DocumentUploadRepository> logger) : base(context)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public override DocumentUpload Update(DocumentUpload entity)
        {
            _dbContext.Entry(entity).Property(e => e.MultiSizeImagePaths).IsModified = true;
            var dbEntityEntry = _dbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                Dbset.Attach(entity);
            }

            dbEntityEntry.State = EntityState.Modified;
            return entity;
        }

        // public async Task<IList<DocumentUpload>> GetAllByParentId(long parentId)
        // {
        //     await using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("MyWebApiConection")))
        //     {
        //         try
        //         {
        //             connection.Open();
        //
        //             var sql = string.Format(@"WITH RECURSIVE recurse_tree AS (
        //                                     SELECT * FROM cms.document_upload WHERE parent_id ={0}
        //                                     UNION
        //                                     SELECT t.*
        //                                     FROM cms.document_upload t
        //                                     JOIN recurse_tree rt ON rt.id = t.parent_id
        //                                     )
        //                                     SELECT * 
        //                                     FROM recurse_tree; 
        //                                     ", parentId);
        //
        //             var ex = await connection.QueryAsync<DocumentUpload>(sql);
        //             return ex.ToList();
        //         }
        //         catch (Exception ex)
        //         {
        //             _logger.LogError($"{ex}");
        //
        //             return null;
        //         }
        //     }
        // }
        //
        // public IList<DocumentUpload> GetChildNode(long id)
        // {
        //     using (var connection = new NpgsqlConnection(_configuration.GetConnectionString("MyWebApiConection")))
        //     {
        //         try
        //         {
        //             connection.Open();
        //
        //             var sql = $@"WITH RECURSIVE recurse_tree AS (SELECT id FROM cms.document_upload WHERE parent_id = @ParentId
        //                         UNION
        //                         SELECT t.id
        //                         FROM cms.document_upload t JOIN recurse_tree rt ON rt.id = t.parent_id)
        //                         SELECT id FROM recurse_tree;";
        //
        //             var ex = connection.Query<DocumentUpload>(sql, new
        //             {
        //                 ParentId = id
        //             });
        //             connection.Close();
        //             return ex.ToList();
        //         }
        //         catch (Exception ex)
        //         {
        //             _logger.LogError($"{ex}");
        //             return null;
        //         }
        //     }
        // }
        //
        // public NodePath GetNodePathById(long id)
        // {
        //     using var connection = new NpgsqlConnection(_configuration.GetConnectionString("MyWebApiConection"));
        //     try
        //     {
        //         connection.Open();
        //
        //         var sql = $@"WITH RECURSIVE Hierarchy ( child_id, child_name, parent_id, node_path ) AS (
        //                             SELECT
        //                                 FirstGeneration.ID,
        //                                 FirstGeneration.NAME,
        //                                 FirstGeneration.parent_id,
        //                                 CAST (FirstGeneration.NAME AS VARCHAR(255))
        //                             FROM
        //                                 cms.document_upload AS FirstGeneration                                        
        //                             WHERE
        //                                 parent_id = 0
        //                             UNION ALL
        //                             SELECT
        //                                 NextGeneration.ID,
        //                                 NextGeneration.NAME,
        //                                 Parent.child_id,
        //                             CAST (
        //                                 CASE WHEN parent.node_path = '' THEN
        //                                 CAST ( p.name AS VARCHAR(255)) ELSE (Parent.node_path || '/' || NextGeneration.NAME)
        //                                 END AS VARCHAR(255)
        //                             )
        //                             FROM
        //                                 cms.document_upload AS NextGeneration
        //                                 INNER JOIN cms.document_upload as p on NextGeneration.parent_id = p.id
        //                                 INNER JOIN Hierarchy AS Parent ON NextGeneration.parent_id = Parent.child_id
        //                             )
        //                             SELECT
        //                                 child_id as Id, child_name as Name, parent_id as ParenId, node_path as Path
        //                             FROM
        //                                 Hierarchy
        //                                 WHERE child_id = @ChildId";
        //
        //         var ex = connection.QueryFirstOrDefault<NodePath>(sql, new
        //         {
        //             ChildId = id
        //         }, connection.BeginTransaction());
        //         connection.Close();
        //         return ex;
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError($"{ex}");
        //
        //         return null;
        //     }
        //}
    }
}
