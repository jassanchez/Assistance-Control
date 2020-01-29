using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using DPFP.Verification;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador_de_Asistencia.Clases
{
    class DigitalPersona
    {
        public Capture captura = new Capture();
        public Enrollment inscripcion = new Enrollment();
        public uint CuentaInscripcion;
        public Template plantilla = new Template();
        public Verification verificador = new Verification();

        public FeatureSet getFeatures(Sample s, DataPurpose proposito)
        {
            FeatureSet caracteristicas = new FeatureSet();
            FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
            CaptureFeedback alimentacion = CaptureFeedback.None;
            extractor.CreateFeatureSet(s, proposito, ref alimentacion, ref caracteristicas);
            if (alimentacion == CaptureFeedback.Good) return caracteristicas;
            else return null;
        }

        public Bitmap convertSampletoBitmap(Sample Sample)
        {
            Bitmap image = null;
            new SampleConversion().ConvertToPicture(Sample, ref image);
            return image;
        }

        public void startCapture() { if (captura != null) captura.StartCapture();}

        public void stopCapture()
        {
            if (captura != null) captura.StopCapture();
        }

        public Enrollment CapturaHuella(Sample sample)
        {
            FeatureSet caracteristicas = getFeatures(sample, DataPurpose.Enrollment);
            if (caracteristicas != null)
            {
                try { inscripcion.AddFeatures(caracteristicas); }
                finally
                {
                    switch (inscripcion.TemplateStatus)
                    {
                        case Enrollment.Status.Ready:
                            plantilla = inscripcion.Template;
                            stopCapture(); break;
                        case Enrollment.Status.Failed:
                            cleanEnrollment();
                            stopCapture();
                            startCapture();
                            break;
                    }
                    CuentaInscripcion = inscripcion.FeaturesNeeded;
                }
            }
            return inscripcion;
        }

        public void cleanEnrollment()
        {
            if (inscripcion != null) inscripcion.Clear();
            CuentaInscripcion = 0;
        }

        public bool verificar(FeatureSet fetureFinger, Template template)
        {
            if (fetureFinger != null)
            {
                Verification.Result resultado = new Verification.Result();
                verificador.Verify(fetureFinger, template, ref resultado);
                return resultado.Verified;
            }
            return false;
        }
    }
}
