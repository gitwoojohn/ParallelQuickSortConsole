using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortApp
{
    class Program
    {
        // const MAX = 10,000,000 
        private static int MAX = 10000000;

        static void Main( string[] args )
        {
            Random r = new Random();
            int[] intArray1 = new int[ MAX ];
            int[] intArray2 = new int[ MAX ];

            for( int i = 0; i < MAX; i++ )
            {
                intArray1[ i ] = r.Next( 1, MAX );
            }
            intArray1.CopyTo( intArray2, 0 );

            // 순차 소트
            Demo_SequentialSort( intArray1 );
            // 병렬 쿽 소트
            Demo_ParallelQuickSort( intArray2 );

            Console.ReadKey();
        }
        private static void Demo_SequentialSort( int[] intArray )
        {
            Console.WriteLine( "\n=== 순차 Sequential 정렬 ===" );
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ParallelQuickSort.QuicksortSequential( intArray );
            stopWatch.Stop();
            Console.WriteLine( $"경과 시간 : {stopWatch.ElapsedMilliseconds / 1000d}초" );
        }
        private static void Demo_ParallelQuickSort( int[] intArray )
        {
            Console.WriteLine( "\n=== 병렬 QucikSort ===" );
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();
            ParallelQuickSort.QuicksortParallel( intArray );
            stopWatch.Stop();
            Console.WriteLine( $"경과 시간 : {stopWatch.ElapsedMilliseconds / 1000d}초" );
        }

    }
}
