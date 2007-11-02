using System;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Blend.xPlatform
{
    public abstract class PlatformInvokeBase
    {
        protected PlatformInvokeBase()
            : base()
        {
            this.rendererList = new Dictionary<string, Converter<MethodInfo, string>>();
        }

        [NonSerialized()]
        private readonly Dictionary<string, Converter<MethodInfo, string>> rendererList;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected IDictionary<string, Converter<MethodInfo, string>> AvailableRenderers
        {
            get { return this.rendererList; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<string> AvailableLanguages
        {
            get { return this.rendererList.Keys as IEnumerable<string>; }
        }

        public string RenderMethod(string language, MethodInfo targetMethod)
        {
            if (language == null)
                throw new ArgumentNullException("language");

            if (targetMethod == null)
                throw new ArgumentNullException("targetMethod");

            if (this.rendererList.ContainsKey(language) &&
                this.rendererList[language] != null)
                return this.rendererList[language].Invoke(targetMethod);

            throw new NotImplementedException(String.Format(
                "선택한 프로그래밍 언어 {0}는 구현되지 않았습니다.", language));
        }

        public string RenderMethod(string language, IEnumerable<MethodInfo> selectedMethods)
        {
            StringBuilder buffer = new StringBuilder();

            foreach (MethodInfo eachMethod in selectedMethods)
                buffer.AppendLine(this.RenderMethod(language, eachMethod));

            return buffer.ToString();
        }

        public IEnumerable<MethodInfo> SelectMethods(Type targetType, Regex methodNameExpression)
        {
            if (targetType == null)
                throw new ArgumentNullException("targetType");

            BindingFlags bindingFlags = (BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            MethodInfo[] selectedMethods = targetType.GetMethods(bindingFlags);

            if (selectedMethods == null || selectedMethods.Length.Equals(0))
                throw new Exception("선택한 형식에서 사용 가능한 정적 메서드가 없습니다.");

            List<MethodInfo> candidateList = new List<MethodInfo>(selectedMethods.Length);
            object[] dllImportAttributes = null;

            foreach (MethodInfo eachMethod in selectedMethods)
            {
                dllImportAttributes = eachMethod.GetCustomAttributes(typeof(DllImportAttribute), false);

                if (dllImportAttributes == null ||
                    dllImportAttributes.Length.Equals(0))
                    continue;

                if (methodNameExpression != null &&
                    !methodNameExpression.IsMatch(eachMethod.Name))
                    continue;

                candidateList.Add(eachMethod);
            }

            return (IEnumerable<MethodInfo>)candidateList.ToArray();
        }

        public IEnumerable<MethodInfo> SelectMethods(Type targetType, string methodNameExpression, RegexOptions options)
        {
            if (methodNameExpression == null)
                throw new ArgumentNullException("methodNameExpression");

            return this.SelectMethods(targetType, new Regex(methodNameExpression, options));
        }

        public IEnumerable<MethodInfo> SelectMethods(Type targetType, string methodNameExpression)
        {
            return this.SelectMethods(targetType, methodNameExpression, RegexOptions.None);
        }

        public IEnumerable<MethodInfo> SelectMethods(Regex methodNameExpression)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression);
        }

        public IEnumerable<MethodInfo> SelectMethods(string methodNameExpression, RegexOptions options)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression, options);
        }

        public IEnumerable<MethodInfo> SelectMethods(string methodNameExpression)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression);
        }
    }
}
