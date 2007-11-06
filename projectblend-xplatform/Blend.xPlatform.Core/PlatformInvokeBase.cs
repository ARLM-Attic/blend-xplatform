/*
 * Project Blend: the Blossom of .NET Development
 * Copyright (c) 2007 남정현
 * 
 * 이 라이브러리는 자유 소프트웨어입니다. 소프트웨어의 피양도자는 자유 소프트웨어 재단이
 * 공표한 GNU 약소 일반 공중 사용 허가서 2.1판 또는 그 이후 판을 임의로 선택해서, 그 규정에
 * 따라 라이브러리를 개작하거나 재배포할 수 있습니다.
 * 
 * 이 라이브러리는 유용하게 사용될 수 있으리라는 희망에서 배포되고 있지만, 특정한 목적에
 * 맞는 적합성 여부나 판매용으로 사용할 수 있으리라는 묵시적인 보증을 포함한 어떠한 형태의
 * 보증도 제공하지 않습니다. 보다 자세한 사항에 대해서는 GNU 약소 일반 공중 사용 허가서를
 * 참고하시기 바랍니다.
 * 
 * GNU 약소 일반 공중 사용 허가서는 이 라이브러리와 함께 제공됩니다. 만약, 이 문서가 누락
 * 되어있다면 자유 소프트웨어 재단으로 문의하시기 바랍니다.
 * 
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA 02111-1307, USA
 * Korean Translation Comes from: http://korea.gnu.org/people/chsong/copyleft/lgpl.ko.html
 * */

using System;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace Blend.xPlatform
{
    /// <summary>
    /// 플랫폼 호출 서비스의 기본 사양을 정의하는 클래스입니다.
    /// </summary>
    public abstract class PlatformInvokeBase
    {
        [NonSerialized]
        public const string ObsoleteTypeCasting = "TODO: 번역을 위하여 임시로 도입한 형식입니다.";

        /// <summary>
        /// 플랫폼 호출 서비스의 기본 사양을 초기화합니다.
        /// </summary>
        /// <remarks>
        /// 이 생성자는 보호된 생성자입니다.
        /// </remarks>
        protected PlatformInvokeBase()
            : base()
        {
            this.rendererList = new Dictionary<string, Converter<MethodInfo, string>>();
        }

        /// <summary>
        /// 프로토타입 정보를 특정 프로그래밍 언어로 표현하는 서비스들을 저장하는
        /// Dictionary 객체입니다.
        /// </summary>
        [NonSerialized()]
        private readonly Dictionary<string, Converter<MethodInfo, string>> rendererList;

        /// <summary>
        /// 프로토타입 정보를 특정 프로그래밍 언어로 표현하는 서비스들을 가져옵니다.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected IDictionary<string, Converter<MethodInfo, string>> AvailableRenderers
        {
            get { return this.rendererList; }
        }

        /// <summary>
        /// 사용 가능한 프로그래밍 언어들의 목록을 가져옵니다.
        /// </summary>
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEnumerable<string> AvailableLanguages
        {
            get { return this.rendererList.Keys as IEnumerable<string>; }
        }

        /// <summary>
        /// 특정 언어 기반의 코드로 선택한 플랫폼 호출 메서드를 렌더링합니다.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// language나 targetMethod가 Null 참조일 경우 발생합니다.
        /// </exception>
        /// <exception cref="System.NotImplementedException">
        /// language에 해당하는 언어 엔진이 없을 때 발생합니다.
        /// </exception>
        /// <param name="language">렌더링에 사용할 프로그래밍 언어의 이름을 지정합니다.</param>
        /// <param name="targetMethod">렌더링할 플랫폼 호출 메서드를 지정합니다.</param>
        /// <returns>렌더링 결과가 문자열로 반환됩니다.</returns>
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

        /// <summary>
        /// 특정 언어 기반의 코드로 다수의 플랫폼 호출 메서드를 렌더링합니다.
        /// </summary>
        /// <param name="language">렌더링에 사용할 프로그래밍 언어의 이름을 지정합니다.</param>
        /// <param name="selectedMethods">렌더링할 플랫폼 호출 메서드들의 집합을 지정합니다.</param>
        /// <returns>다수의 렌더링 결과가 문자열로 반환됩니다.</returns>
        public string RenderMethod(string language, IEnumerable<MethodInfo> selectedMethods)
        {
            StringBuilder buffer = new StringBuilder();

            foreach (MethodInfo eachMethod in selectedMethods)
                buffer.AppendLine(this.RenderMethod(language, eachMethod));

            return buffer.ToString();
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// targetType - 또는 - methodNameExpression이 Null 참조일 경우 발생합니다.
        /// </exception>
        /// <param name="targetType">플랫폼 호출 메서드 정의를 포함하는 형식을 지정합니다.</param>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식으로 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(Type targetType, Regex methodNameExpression)
        {
            if (targetType == null)
                throw new ArgumentNullException("targetType");

            // Append: methodNameExpression이 Null 참조인 경우를 거절합니다.
            if (methodNameExpression == null)
                throw new ArgumentNullException("methodNameExpression");

            BindingFlags bindingFlags = (BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            MethodInfo[] selectedMethods = targetType.GetMethods(bindingFlags) ??
                (MethodInfo[])Array.CreateInstance(typeof(MethodInfo), 0);

            // Change: Exception을 발생시키지 않는 대신 빈 배열을 반환합니다.
            if (selectedMethods.Length.Equals(0))
                return (IEnumerable<MethodInfo>)selectedMethods;

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

            // Change: 배열로 변환하지 않고 반환합니다.
            return (IEnumerable<MethodInfo>)candidateList;
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <param name="targetType">플랫폼 호출 메서드 정의를 포함하는 형식을 지정합니다.</param>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식 문자열로 지정합니다.</param>
        /// <param name="options">정규 표현식 처리 방법을 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(Type targetType, string methodNameExpression, RegexOptions options)
        {
            if (methodNameExpression == null)
                throw new ArgumentNullException("methodNameExpression");

            return this.SelectMethods(targetType, new Regex(methodNameExpression, options));
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <param name="targetType">플랫폼 호출 메서드 정의를 포함하는 형식을 지정합니다.</param>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식 문자열로 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(Type targetType, string methodNameExpression)
        {
            return this.SelectMethods(targetType, methodNameExpression, RegexOptions.None);
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 현재 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식으로 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(Regex methodNameExpression)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression);
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 현재 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식 문자열로 지정합니다.</param>
        /// <param name="options">정규 표현식 처리 방법을 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(string methodNameExpression, RegexOptions options)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression, options);
        }

        /// <summary>
        /// 플랫폼 호출 메서드 정의를 포함하는 현재 형식으로부터 다수의 메서드를 선택합니다.
        /// </summary>
        /// <param name="methodNameExpression">선택할 메서드 이름의 조건을 정규 표현식 문자열로 지정합니다.</param>
        /// <returns>조건에 맞는 메서드들을 포함하는 컬렉션을 반환합니다.</returns>
        public IEnumerable<MethodInfo> SelectMethods(string methodNameExpression)
        {
            return this.SelectMethods(this.GetType(), methodNameExpression);
        }
    }
}
