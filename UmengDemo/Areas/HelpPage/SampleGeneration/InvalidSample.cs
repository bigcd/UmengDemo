�}j[  Z  }�HvI̎C�u
 xTN�K8�p>��-ָ8���>_���ӲJ
x�߼��	_�B{]��N���q�|�:D-�!�k�x�h�K�pb6RE�"���o��aÌ�+��f�=��ǈ�_���]��(�^z�k�S#�a��8���q�~Q�g��ʿ��Kop��D�ns_g�$%9`\ޔ�y�W��QMn�%��es��V֏�Ͳ���7�����L*E�K�˻�Fm}��zWʽ�#�ʊ�H��,�����J6m��.�Җ�"��Ia}�r�F�N�o���0���+�1�m�Ѱ�
xɻh
��{��k�{�n;�>���%X�K͂0l�a{�vb�u�c�'BF[��6���X.cTl�A4TK��
����/�W�?�.�XS��g�Jk{������5��$G϶	2���6�p�^A�v�����M-����$u��_�KL�pD�$5t�2�fr>�؉im�I�ѽOM�l�:Rkc�&�y�Z8D��{�5j�ppublic string ErrorMessage { get; private set; }

        public override bool Equals(object obj)
        {
            InvalidSample other = obj as InvalidSample;
            return other != null && ErrorMessage == other.ErrorMessage;
        }

        public override int GetHashCode()
        {
            return ErrorMessage.GetHashCode();
        }

        public override string ToString()
        {
            return ErrorMessage;
        }
    }
}