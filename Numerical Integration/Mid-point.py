#Numerical Integration using Mid-point

import math

def f(x):                               #Integration Function
    return x*x
l
def mid_point(a,b,n,I):                 

    del_x= (b-a)/n                      #Interval Increment Value                    

    interval=[]
    interval_mid=[]
    i=0
    while i<=b:
        #print(i)
        if i+del_x<=b:
            interval.append([i,i+del_x])
        i+=del_x

    print(interval)

    for i in range(0,len(interval)):
        interval_mid.append((interval[i][0]+interval[i][1])/2)

    print(interval_mid)

    M=0
    for j in range(0,len(interval_mid)):
        M+=( (1/4) * f(interval_mid[j]) )
    print(M)
    Error=abs(I-M)

    print('Error=',Error)
        
mid_point(0,1,4,(1/3))

'''
#OUTPUT:
[0, 0.25], [0.25, 0.5], [0.5, 0.75], [0.75, 1.0]]
[0.125, 0.375, 0.625, 0.875]
0.328125
Error= 0.005208333333333315
'''
