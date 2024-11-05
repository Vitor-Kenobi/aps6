using OpenCvSharp;
using FaceAiSharp;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Image = SixLabors.ImageSharp.Image;

namespace CNPA
{
    public class Reconhecimento
    {
        private Image<Rgb24> img1, img2;
        private double ponto;
        private static VideoCapture capture;

        public Reconhecimento(string caminhoImg1, string caminhoImg2)
        {
            img1 = Image.Load<Rgb24>(caminhoImg1);
            img2 = Image.Load<Rgb24>(caminhoImg2);
            capture = new VideoCapture(0);
        }

        public static void IniciarCaptura(PictureBox pBox)
        {
            capture = new VideoCapture(0);
            Mat image = new Mat();
            
            while (true)
            {
                capture.Read(image);
                if (image.Empty()) return;
                pBox.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
                int key = Cv2.WaitKey(30);
                if (key == 27) break;
            }
        }

        public static void FinalizarCaptura()
        {
            try
            {
                capture.Release();
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        public static void CapturarImagem(string cpf)
        {

            //string projDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string projDir = Path.GetDirectoryName(Application.ExecutablePath);

            if (!capture.IsOpened())
                throw new Exception("Não foi possível acessar a câmera.");

            using var frame = new Mat();
            capture.Read(frame);
            if (frame.Empty())
                throw new Exception("Não foi possível capturar a imagem.");

            string caminhoImagem = projDir+@"\resources\imagens\"+cpf+".jpg";
            Cv2.ImWrite(caminhoImagem, frame);

        }
        public double Comparar()
        {
            // Detector de faces
            IFaceDetectorWithLandmarks det = FaceAiSharpBundleFactory.CreateFaceDetectorWithLandmarks();
            // Reconhecedor de faces
            IFaceEmbeddingsGenerator rec = FaceAiSharpBundleFactory.CreateFaceEmbeddingsGenerator();

            // Detectando faces
            var primeira = det.DetectFaces(img1).First();
            var segunda = det.DetectFaces(img2).First();

            // Alinhando as faces e realizando reconhecimento
            rec.AlignFaceUsingLandmarks(img1, primeira.Landmarks!);
            rec.AlignFaceUsingLandmarks(img2, segunda.Landmarks!);

            // Gerando as matrizes
            var embedding1 = rec.GenerateEmbedding(img1);
            var embedding2 = rec.GenerateEmbedding(img2);

            // Comparando faces e gerando uma acurácia
            var ponto = FaceAiSharp.Extensions.GeometryExtensions.Dot(embedding1, embedding2);

            return ponto;
        }
    }
}