using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Twitter.Entities {

    public class TwitterHashTagEntity : TwitterBaseEntity {

        #region Properties

        public string Text { get; private set; }

        #endregion

        #region Constructors

        private TwitterHashTagEntity() { }

        #endregion

        #region Static methods

        public static TwitterHashTagEntity Parse(JObject entity) {
            return new TwitterHashTagEntity {
                Text = entity.GetString("text"),
                StartIndex = entity.GetArray("indices").GetInt32(0),
                EndIndex = entity.GetArray("indices").GetInt32(1)
            };
        }

        #endregion

    }

}