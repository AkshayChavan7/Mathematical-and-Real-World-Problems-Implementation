#Numerical Differentiation using Two-Point and Three-Point Formula

def f(x):
    return x*x


def two_point(x,h):
    return ((f(x+h)-f(x))/h)


def three_point(x,h):
    return ((f(x+h)-f(x-h))/(2*h))


def differentiate(x):

    h=0.25
    
    print('Differentiation for point ',x,' using Two-Point Method is: ',two_point(x,h))
    print('Differentiation for point ',x,' using Three-Point Method is: ',three_point(x,h))

differentiate(3)
