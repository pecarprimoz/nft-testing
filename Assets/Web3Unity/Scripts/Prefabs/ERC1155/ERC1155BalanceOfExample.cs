using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;

public class ERC1155BalanceOfExample : MonoBehaviour
{
    async void Start()
    {
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0x88B48F654c30e99bc2e4A1559b4Dcf1aD93FA656";
        string account = "0x6785Cb8320ecb7BCfE16354DaBE4669043DB5f44";
        string tokenId = "46824618653420748357732825205362865295501312755091421150630032016295245905921";

        BigInteger balanceOf = await ERC1155.BalanceOf(chain, network, contract, account, tokenId);
        if (!balanceOf.IsZero) {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        print(balanceOf);
    }
}
