using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using System.Net;


namespace VkAlbumDownloader
{
    public partial class Form1 : Form
    {
        
        VkApi api = new VkApi();   
        bool isAuthorizedSuccess = false;
        Dictionary<String, String> urls = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            if (!IsFieldsEmpty())
            {
                try
                {
                    //Authorizing();
                    //AlbumAddress albumAddress = ParseUrl(tbSource.Text);
                    //List<VkCollection<Photo>> get = GetPhotos(albumAddress);
                    //Dictionary<String, String> urls = GetUrls(get);
                    string path = ChooseFolderPath();
                    Download(urls, path);
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Будьте внимательны", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsFieldsEmpty()
        {
            return string.IsNullOrEmpty(tbToken.Text) || string.IsNullOrEmpty(tbSource.Text) ;
        }


        private List<VkCollection<Photo>> GetPhotos(AlbumAddress albumAddress)
        {
            List<VkCollection<Photo>> get = new List<VkCollection<Photo>>();
            int size = 0;
            if (isAuthorizedSuccess)
            {
                try
                {
                    int dsize = 1;
                    int i = 0;
                    while (dsize > 0)
                    {
                        dsize = 0;
                        VkCollection<Photo> photos = null;
                        photos = api.Photo.Get(new PhotoGetParams
                        {
                            Count = 1000,
                            OwnerId = albumAddress.OwnerId,
                            AlbumId = albumAddress.GetPhotoAlbum,
                            Extended = true,
                            PhotoSizes = true,
                            Offset = 1000 * (ulong)i
                        }) ;
                        dsize = photos.Count();
                        size += dsize;
                        get.Add(photos);
                        i++;
                        
                    }

                    lblCountPhotos.Text = size.ToString();
                }
                catch (Exception ex)
                {
                    lblCountPhotos.Text = "Error - "+ ex.Message;
                    Debug.WriteLine("error get photos");
                    throw;
                }
            }
            return get;
        }

        private void Authorizing()
        {
            try
            {
                api.Authorize(new ApiAuthParams
                {
                    AccessToken = tbToken.Text
                });

                var res = api.Groups.Get(new GroupsGetParams());
                setTokenState(api.IsAuthorized);
                isAuthorizedSuccess = true;
                
            }
            catch
            {
                lblTockenState.Text = "Error of authorize";
                isAuthorizedSuccess = false;
                throw;
            }
            URLFieldsEnable(isAuthorizedSuccess);
        }

        private Dictionary<String, String> GetUrls(List<VkCollection<Photo>> get)
        {
            Dictionary<String, String> urls = new Dictionary<string, string>();
            foreach (VkCollection<Photo> photos in get)
            {
                foreach (Photo photo in photos)
                {
                    try
                    {
                        var sizes = photo.Sizes;
                        string url = sizes[sizes.Count - 1].Url.ToString();
                        urls.Add(photo.ToString(), url);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("error getting url - " + ex.Message);
                        throw;
                    }

                }
            }
            return urls;
        }

        private void Download(Dictionary<String,String> urls, string path)
        {
            progressBar.Value = 0;
            int i = 0;
            int success = 0;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Неверный путь", "Выбор папки", MessageBoxButtons.OK, MessageBoxIcon. Error);
                return;
            }
            foreach (KeyValuePair<String, String> pair in urls)
            {
                i++;
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadFileAsync(
                            // Param1 = Link of file
                            new System.Uri(pair.Value),
                            // Param2 = Path to save
                            path+"\\" + pair.Key + ".jpg"
                        );
                    }
                    success++;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                progressBar.Value = (int)(i / (urls.Count * 0.01));
            }
            MessageBox.Show("Загружено "+success.ToString()+" из "+urls.Count.ToString(), "Загрузка завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar.Value = 0;
        }
        
        private String ChooseFolderPath()
        {
            string path= "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            
            return path;
        }

        private void AlbumName(AlbumAddress albumAddress)
        {
            if (isAuthorizedSuccess)
            {
                try
                {
                    if (albumAddress.isDefaultAlbum())
                    {
                        var album = api.Photo.GetAlbums(new PhotoGetAlbumsParams
                        {
                            OwnerId = albumAddress.OwnerId,
                            AlbumIds = new List<long>() { Convert.ToInt64(albumAddress.AlbumId) }
                        });
                        lblAlbumName.Text = album[0].Title;
                    }
                    else
                    {
                        lblAlbumName.Text = albumAddress.GetAlbumName();
                    }

                }
                catch
                {

                    Debug.WriteLine("error get album name");
                    throw;
                }
            }
        }

        private AlbumAddress ParseUrl(string value)
        {
            string source = value;
            int index = 0;
            string albumId = "";
            string ownerId = "";
            int shiftIndex = 5;
            AlbumAddress albumAddress = new AlbumAddress();

            if (source.Contains("album"))
            {
                index = source.IndexOf("album");

                while (!source[index+shiftIndex].Equals('_'))
                {
                    ownerId += source[index + shiftIndex];
                    shiftIndex++;
                }

                shiftIndex++;

                while(index + shiftIndex!=source.Length)
                {
                    albumId += source[index + shiftIndex];
                    shiftIndex++;
                }
                Debug.WriteLine("owner= "+ownerId.ToString()+"\nalbumid= "+albumId.ToString());

                albumAddress.AlbumId = albumId;
                albumAddress.OwnerId = Convert.ToInt64(ownerId);

                return albumAddress;
            }
            else
            {
                Debug.WriteLine("error of source url !");
                return null;
            }

        }

        private void btnEnterToken_Click(object sender, EventArgs e)
        {
            Authorizing();
        }

        private void DownloadButtonEnable(bool value)
        {
            DownloadButton.Enabled = value;
        }
        private void InfoFieldsClear()
        {
            lblAlbumName.Text = "---";
            lblCountPhotos.Text = "---";
        }

        private void URLFieldsEnable(bool value)
        {
                tbSource.Enabled = value;
                btnURLEnter.Enabled = value;
        }

        private void btnURLEnter_Click(object sender, EventArgs e)
        {
            bool isAlbumEnable = false;
            if (!IsFieldsEmpty())
            {
                try
                {
                    Authorizing();
                    AlbumAddress albumAddress = ParseUrl(tbSource.Text);
                    List<VkCollection<Photo>> get = GetPhotos(albumAddress);
                    urls = GetUrls(get);
                    AlbumName(albumAddress);
                    isAlbumEnable = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isAlbumEnable = false;
                }


            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Будьте внимательны", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isAlbumEnable = false;
            }

            DownloadButtonEnable(isAlbumEnable);
        }

        private void tbToken_TextChanged(object sender, EventArgs e)
        {
            URLFieldsEnable(false);
            DownloadButtonEnable(false);
            InfoFieldsClear();
            setTokenState(false);
            
        }

        private void tbSource_TextChanged(object sender, EventArgs e)
        {
            DownloadButtonEnable(false);
            InfoFieldsClear();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.infoMessage, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setTokenState(bool value)
        {
            if (value)
            {
                lblTockenState.Text = "активен";
                lblTockenState.ForeColor = Color.Green;
            }
            else
            {
                lblTockenState.Text = "не активен";
                lblTockenState.ForeColor = Color.Red;
            }
        }
    }
}
