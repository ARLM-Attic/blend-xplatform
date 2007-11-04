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
using System.Collections.Generic;
using System.Text;

namespace Blend.xPlatform
{
    /// <summary>
    /// C/C++의 typedef 문이나 #define 매크로와의 호환성을 위하여 사용합니다.
    /// 이 형식의 경우 읽기/쓰기 작업이 모두 가능한 인스턴스를 나타냅니다.
    /// </summary>
    /// <typeparam name="T">호환성을 부여할 형식을 지정합니다.</typeparam>
    [Serializable]
    public class ReadOnlyCompromisingType<T> : ICompromisingType<T>
    {
        /// <summary>
        /// 기본 생성자입니다.
        /// </summary>
        protected internal ReadOnlyCompromisingType()
            : this(default(T))
        {
        }

        /// <summary>
        /// 기본값을 지정하여 초기화합니다.
        /// </summary>
        /// <param name="innerVariable">기본값 - 또는 - 기본 객체입니다.</param>
        protected internal ReadOnlyCompromisingType(T innerVariable)
            : base()
        {
            this.innerVariable = innerVariable;
        }

        /// <summary>
        /// 내부 변수이며, 읽기 전용입니다.
        /// </summary>
        private readonly T innerVariable = default(T);

        /// <summary>
        /// 내부 형식 개체를 가져옵니다.
        /// </summary>
        /// <exception cref="System.NotSupportedException">
        /// Setter 메서드를 호출하면 발생합니다.
        /// </exception>
        /// <remarks>
        /// Setter 메서드는 지원되지 않습니다.
        /// </remarks>
        public T InnerVariable
        {
            get { return this.innerVariable; }
            set { throw new NotSupportedException("Read-only type."); }
        }

        /// <summary>
        /// 지정한 개체가 현재 개체와 같은지 판정합니다.
        /// </summary>
        /// <param name="other">형식 인수 T에 해당하거나 호환되는 개체입니다.</param>
        /// <returns>같음으로 판정되면 True, 그렇지 않으면 False를 반환합니다.</returns>
        public bool Equals(T other)
        {
            return this.innerVariable.Equals(other);
        }

        /// <summary>
        /// 지정한 개체가 현재 개체와 같은지 판정합니다.
        /// </summary>
        /// <param name="other">형식 인수 T에 대한 별칭 형식으로서, 형식 인수 T에 해당하거나 호환성을 가지는 개체입니다.</param>
        /// <returns>같음으로 판정되면 True, 그렇지 않으면 False를 반환합니다.</returns>
        public bool Equals(ICompromisingType<T> other)
        {
            return this.innerVariable.Equals(other.InnerVariable);
        }

        /// <summary>
        /// 지정한 개체가 현재 개체와 같은지 판정합니다.
        /// </summary>
        /// <param name="obj">비교할 대상 개체입니다.</param>
        /// <returns>같음으로 판정되면 True, 그렇지 않으면 False를 반환합니다.</returns>
        public override bool Equals(object obj)
        {
            if (obj is T)
                return this.Equals((T)obj);
            else if (obj is ICompromisingType<T>)
                return this.Equals((ICompromisingType<T>)obj);
            else
                return base.Equals(obj);
        }

        /// <summary>
        /// 현재 개체에 대한 해시 값을 생성합니다.
        /// </summary>
        /// <returns>현재 개체에 대한 해시 값을 반환합니다.</returns>
        public override int GetHashCode()
        {
            return this.innerVariable.GetHashCode();
        }

        /// <summary>
        /// 현재 개체에 대한 형식 정보나 실제 데이터를 표현하는 문자열을 생성합니다.
        /// </summary>
        /// <returns>형식 정보나 데이터를 포함하는 문자열을 반환합니다.</returns>
        public override string ToString()
        {
            return this.innerVariable.ToString();
        }

        /// <summary>
        /// 컨테이너에서 형식 인수 T로의 암묵적인 변환을 중계합니다.
        /// 형식 인수 T를 필요로 하는 매개 변수나 데입문에서 자동으로 실행됩니다.
        /// </summary>
        /// <param name="obj">현재 개체의 참조가 전달됩니다.</param>
        /// <returns>내부 변수 - 또는 - 개체가 반환됩니다.</returns>
        public static implicit operator T(ReadOnlyCompromisingType<T> obj)
        {
            return obj.InnerVariable;
        }

        /// <summary>
        /// 형식 인수 T에서 컨테이너로의 암묵적인 변환을 중계합니다.
        /// 형식 인수 T에 대한 별칭 형식을 필요로 하는 매개 변수나 대입문에서 자동으로 실행됩니다.
        /// </summary>
        /// <param name="obj">대입할 개체의 참조가 전달됩니다.</param>
        /// <returns>새로운 컨테이너를 생성하여 반환합니다.</returns>
        public static implicit operator ReadOnlyCompromisingType<T>(T obj)
        {
            return new ReadOnlyCompromisingType<T>(obj);
        }

        /// <summary>
        /// 읽기 전용 컨테이너에서 일반 컨테이너로의 암묵적인 변환을 중계합니다.
        /// </summary>
        /// <param name="obj">현재 개체의 참조가 전달됩니다.</param>
        /// <returns>새로운 일반 컨테이너를 생성하여 반환합니다.</returns>
        public static implicit operator CompromisingType<T>(ReadOnlyCompromisingType<T> obj)
        {
            return new CompromisingType<T>(obj.innerVariable);
        }

        /// <summary>
        /// 일반 컨테이너에서 읽기 전용 컨테이너로의 암묵적인 변환을 중계합니다.
        /// </summary>
        /// <param name="obj">현재 개체의 참조가 전달됩니다.</param>
        /// <returns>새로운 읽기 전용 컨테이너를 생성하여 반환합니다.</returns>
        public static implicit operator ReadOnlyCompromisingType<T>(CompromisingType<T> obj)
        {
            return new ReadOnlyCompromisingType<T>(obj.InnerVariable);
        }
    }
}
