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

        public Reconhecimento(String caminhoImg1, String caminhoImg2)
        {
            img1 = Image.Load<Rgb24>(path: caminhoImg1);
            img2 = Image.Load<Rgb24>(path: caminhoImg2);
        }

        public Double Comparar()
        {
            // Detector
            IFaceDetectorWithLandmarks det = FaceAiSharpBundleFactory.CreateFaceDetectorWithLandmarks();
            // Reconhecedor
            IFaceEmbeddingsGenerator rec = FaceAiSharpBundleFactory.CreateFaceEmbeddingsGenerator();

            // Detectando faces
            var primeira = det.DetectFaces(img1).First();
            var segunda = det.DetectFaces(img2).First();

            // Alinhando as faces e realizando reconhecimento
            rec.AlignFaceUsingLandmarks(img1, primeira.Landmarks!);
            rec.AlignFaceUsingLandmarks(img2, segunda.Landmarks!);


            var embedding1 = rec.GenerateEmbedding(img1);
            var embedding2 = rec.GenerateEmbedding(img2);

            // Comparando faces e gerando uma acurácia
            var ponto = FaceAiSharp.Extensions.GeometryExtensions.Dot(embedding1, embedding2);

            return ponto;
        }
    }
}
