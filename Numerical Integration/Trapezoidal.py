#Numerical Integration using Trapezoidal Rule

import math

#f(x)= square_root(x^2 +1)
def f(x):       
    return (math.sqrt((x*x)+1))


def trapezoidal(a,b,n):

    del_x=(b-a)/n
    #print('del_x:', del_x)
    y=[]
    i=a
    t=0
    while t<=n:
        i=f(a+(t*del_x))
        #print(i)
        y.append(i)
        t+=1
    #print(y)

    sum=0
    for j in range(1,n):
        #print(y[j])
        sum+=y[j]

    #print('Intervals List(y): ',y)
    area=del_x * ( (y[0]/2) + sum + ((y[len(y)-1])/2) )

    #print('Area: ',area)
    return area
#trapezoidal(0,1,125)


'''
OUTPUT:
del_x: 0.2
Intervals List(y):  [1.0, 1.019803902718557, 1.077032961426901, 1.1661903789690602, 1.2806248474865698, 1.4142135623730951]
Area:  1.1501517743575271

'''
